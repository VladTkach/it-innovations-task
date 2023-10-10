import {Component, OnInit} from '@angular/core';
import {BookService} from "../../../core/services/book.service";
import {BookDto} from "../../../models/book/book-dto";
import {BaseComponent} from "../../../core/base/base.component";
import {takeUntil} from "rxjs";

@Component({
  selector: 'app-books-page',
  templateUrl: './books-page.component.html',
  styleUrls: ['./books-page.component.sass']
})
export class BooksPageComponent extends BaseComponent implements OnInit{
  public books: BookDto[] = [];
  constructor(private bookService: BookService) {
    super();
  }

  public ngOnInit(): void {
    this.loadBooks();
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
