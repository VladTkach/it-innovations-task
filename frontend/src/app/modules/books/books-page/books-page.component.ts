import {Component, OnInit} from '@angular/core';
import {BookService} from "../../../core/services/book.service";
import {BookDto} from "../../../models/book/book-dto";
import {BaseComponent} from "../../../core/base/base.component";
import {takeUntil} from "rxjs";
import {MatDialog} from "@angular/material/dialog";
import {CreateBookModalComponent} from "../create-book-modal/create-book-modal.component";
import {UpdateBookDto} from "../../../models/book/update-book-dto";
import {FormBuilder, FormGroup} from "@angular/forms";
import * as XLSX from 'xlsx';

@Component({
  selector: 'app-books-page',
  templateUrl: './books-page.component.html',
  styleUrls: ['./books-page.component.sass']
})
export class BooksPageComponent extends BaseComponent implements OnInit {
  public books: BookDto[] = [];
  public filteredBooks: BookDto[] = [];
  public selectedBooks: BookDto[] = [];

  public sortValue: string[] = ['Name', 'Date', 'Page count'];
  public selectedSort?: string;

  public filterForm?: FormGroup;

  public updatedBook?: UpdateBookDto;
  public showCancelBtn = false;

  constructor(public dialog: MatDialog,
              private bookService: BookService,
              private formBuilder: FormBuilder) {
    super();
  }

  public ngOnInit(): void {
    this.loadBooks();
    this.loadForm();
  }

  public openCreateModal() {
    const dialogRef = this.dialog.open(CreateBookModalComponent, {
      width: '450px',
      autoFocus: false,
      data: {
        isUpdate: false,
        updateBook: undefined
      }
    });

    dialogRef.componentInstance.bookCreated.subscribe((newBook) => {
      this.books.push(newBook);
      this.filterBooks();
      dialogRef.close();
    })
  }

  public updateBook(book: BookDto) {
     this.updatedBook = {
      id: book.id,
      name: book.name,
      description: book.description,
      pageCount: book.pageCount,
      createdAt: new Date(book.createdAt)
    }

    const dialogRef = this.dialog.open(CreateBookModalComponent, {
      width: '450px',
      autoFocus: false,
      data: {
        isUpdate: true,
        updateBook: {...this.updatedBook}
      }
    });

    dialogRef.componentInstance.bookCreated.subscribe((newBook) => {
      this.updateBookHandle(newBook);
      dialogRef.close();
      this.showCancelBtn = true;
    })

  }

  public deleteBook(bookId: number) {
    console.log(bookId);
    this.bookService.deleteBook(bookId)
      .pipe(takeUntil(this.unsubscribe$))
      .subscribe({
        next: _ => this.deleteBookHandle(bookId)
      })
  }

  public cancelUpdate() {
    if (!this.updatedBook){
      return;
    }
    this.bookService.updateBook(this.updatedBook)
      .pipe(takeUntil(this.unsubscribe$))
      .subscribe({
        next: newBook => {
          this.updateBookHandle(newBook);
          this.showCancelBtn = false;
        }
      })
  }

  public filterBooks() {
    this.filteredBooks = this.books.filter(b =>  this.isSelected(b) || b.name.includes(this.filterForm?.value.name));

    if (this.filterForm?.value.start && this.filterForm?.value.end) {

      const startDate = new Date(this.filterForm?.value.start);
      const endDate = new Date(this.filterForm?.value.end);

      this.filteredBooks = this.filteredBooks.filter(b => {
        const createdAt = new Date(b.createdAt);

        return this.isSelected(b) || (createdAt >= startDate && createdAt <= endDate);
      });
    }
    this.sortBooks();
  }

  public setThisMonth() {
    const today = new Date();
    const firstDayOfMonth = new Date(today.getFullYear(), today.getMonth(), 1);
    const lastDayOfMonth = new Date(today.getFullYear(), today.getMonth() + 1, 0);
    this.filterForm?.get('start')?.setValue(firstDayOfMonth);
    this.filterForm?.get('end')?.setValue(lastDayOfMonth);
    this.filterBooks();
  }

  public setThisYear() {
    const today = new Date();
    const firstDayOfYear = new Date(today.getFullYear(), 0, 1);
    const lastDayOfYear = new Date(today.getFullYear(), 11, 31);
    this.filterForm?.get('start')?.setValue(firstDayOfYear);
    this.filterForm?.get('end')?.setValue(lastDayOfYear);
    this.filterBooks();
  }

  public resetDate() {
    this.filterForm?.get('start')?.setValue(null);
    this.filterForm?.get('end')?.setValue(null);
    this.filterBooks();
  }

  public isSelected(book: BookDto): boolean {
    return this.selectedBooks.some(selectedBook => selectedBook.id === book.id);
  }

  public toggleSelection(book: BookDto): void {
    const index = this.selectedBooks.findIndex(selectedBook => selectedBook.id === book.id);
    if (index === -1) {
      this.selectedBooks.push(book);
    } else {
      this.selectedBooks.splice(index, 1);
    }

    this.filterBooks();
  }

  public exportExcel() {
    const ws: XLSX.WorkSheet = XLSX.utils.json_to_sheet(this.filteredBooks);
    const wb: XLSX.WorkBook = XLSX.utils.book_new();
    XLSX.utils.book_append_sheet(wb, ws, 'Books');
    XLSX.writeFile(wb, 'Books.xlsx');
  }

  private sortBooks(){
    switch (this.selectedSort) {
      case 'Name':
        this.filteredBooks = this.filteredBooks.sort((a, b) => a.name.localeCompare(b.name));
        break;
      case 'Date':
        this.filteredBooks = this.filteredBooks.sort((a, b) => {
          if (a.createdAt > b.createdAt) return 1;
          if (a.createdAt < b.createdAt) return -1;
          return 0;
        });
        break;
      case 'Page count':
        this.filteredBooks = this.filteredBooks.sort((a, b) => a.pageCount - b.pageCount);
        break;
    }
  }

  private loadBooks() {
    this.bookService.getAllBooks()
      .pipe(takeUntil(this.unsubscribe$))
      .subscribe({
        next: books => {
          this.books = books;
          this.filteredBooks = books;
        }
      })
  }

  private loadForm() {
    this.filterForm = this.formBuilder.group({
      name: [''],
      start: [null],
      end: [null],
    })
  }

  private deleteBookHandle(bookId: number){
    const bookIndex = this.books.findIndex(b => b.id === bookId);
    if (bookIndex !== -1) {
      this.books.splice(bookIndex, 1);
    }

    const index = this.selectedBooks.findIndex(selectedBook => selectedBook.id === bookId);
    if (index !== -1) {
      this.selectedBooks.splice(index, 1);
    }

    this.filterBooks();
  }

  private updateBookHandle(newBook: BookDto){
    const bookIndex = this.books.findIndex(b => b.id == newBook.id);
    if (bookIndex != -1) {
      this.books.splice(bookIndex, 1, newBook);
    }

    const index = this.selectedBooks.findIndex(selectedBook => selectedBook.id === newBook.id);
    if (index !== -1) {
      this.selectedBooks.splice(index, 1, newBook);
    }

    this.filterBooks();
  }
}
