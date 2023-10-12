import {Component, OnInit} from '@angular/core';
import {BookService} from "../../../core/services/book.service";
import {BookDto} from "../../../models/book/book-dto";
import {BaseComponent} from "../../../core/base/base.component";
import {takeUntil} from "rxjs";
import {MatDialog} from "@angular/material/dialog";
import {CreateBookModalComponent} from "../create-book-modal/create-book-modal.component";
import {UpdateBookDto} from "../../../models/book/update-book-dto";
import {FormBuilder, FormGroup} from "@angular/forms";
import {group} from "@angular/animations";

@Component({
  selector: 'app-books-page',
  templateUrl: './books-page.component.html',
  styleUrls: ['./books-page.component.sass']
})
export class BooksPageComponent extends BaseComponent implements OnInit {
  public books: BookDto[] = [];
  public filteredBooks: BookDto[] = [];

  public filterForm?: FormGroup;

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
      dialogRef.close();
    })
  }

  public updateBook(book: BookDto) {
    const updatedBook: UpdateBookDto = {
      id: book.id,
      name: book.name,
      description: book.description,
      pageCount: book.pageCount
    }

    const dialogRef = this.dialog.open(CreateBookModalComponent, {
      width: '450px',
      autoFocus: false,
      data: {
        isUpdate: true,
        updateBook: updatedBook
      }
    });

    dialogRef.componentInstance.bookCreated.subscribe((newBook) => {
      const bookIndex = this.books.findIndex(b => b.id == newBook.id);
      if (bookIndex != -1) {
        this.books.splice(bookIndex, 1, newBook);
      }
      dialogRef.close();
    })

  }

  public deleteBook(bookId: number) {
    console.log(bookId);
    this.bookService.deleteBook(bookId)
      .pipe(takeUntil(this.unsubscribe$))
      .subscribe({
        next: _ => {
          const bookIndex = this.books.findIndex(b => b.id === bookId);
          if (bookIndex !== -1) {
            this.books.splice(bookIndex, 1);
          }
        }
      })
  }

  public filterBooks() {
    this.filteredBooks = this.books.filter(b => b.name.includes(this.filterForm?.value.name))
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
    })
  }
}
