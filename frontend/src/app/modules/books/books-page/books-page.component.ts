import {Component, OnInit} from '@angular/core';
import {BookService} from "../../../core/services/book.service";
import {BookDto} from "../../../models/book/book-dto";
import {BaseComponent} from "../../../core/base/base.component";
import {takeUntil} from "rxjs";
import {MatDialog} from "@angular/material/dialog";
import {CreateBookModalComponent} from "../create-book-modal/create-book-modal.component";
import {UpdateBookDto} from "../../../models/book/update-book-dto";

@Component({
  selector: 'app-books-page',
  templateUrl: './books-page.component.html',
  styleUrls: ['./books-page.component.sass']
})
export class BooksPageComponent extends BaseComponent implements OnInit{
  public books: BookDto[] = [];
  constructor(public dialog: MatDialog,private bookService: BookService) {
    super();
  }

  public ngOnInit(): void {
    this.loadBooks();
  }

  public openCreateModal(){
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

  public updateBook(book: BookDto){
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
      if (bookIndex != -1){
        this.books.splice(bookIndex, 1, newBook);
      }
      dialogRef.close();
    })

  }

  public deleteBook(bookId: number){
    console.log(bookId);
    this.bookService.deleteBook(bookId)
      .pipe(takeUntil(this.unsubscribe$))
      .subscribe({
        next: _ => {
          const bookIndex = this.books.findIndex(b => b.id === bookId);
          if (bookIndex !== -1){
            this.books.splice(bookIndex, 1);
          }
        }
      })
  }

  private loadBooks(){
    this.bookService.getAllBooks()
      .pipe(takeUntil(this.unsubscribe$))
      .subscribe({
        next: books => {
          this.books = books;
        }
    })
  }
}
