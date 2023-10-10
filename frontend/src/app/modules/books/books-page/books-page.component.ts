import {Component, OnInit} from '@angular/core';
import {BookService} from "../../../core/services/book.service";
import {BookDto} from "../../../models/book/book-dto";
import {BaseComponent} from "../../../core/base/base.component";
import {takeUntil} from "rxjs";
import {MatDialog} from "@angular/material/dialog";
import {CreateBookModalComponent} from "../create-book-modal/create-book-modal.component";

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
      autoFocus: false
    });

    dialogRef.componentInstance.bookCreated.subscribe((newBook) => {
      this.books.push(newBook);
      dialogRef.close();
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
