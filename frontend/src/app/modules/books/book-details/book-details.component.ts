import {Component, EventEmitter, Input, Output} from '@angular/core';
import {BookDto} from "../../../models/book/book-dto";

@Component({
  selector: 'app-book-details',
  templateUrl: './book-details.component.html',
  styleUrls: ['./book-details.component.sass']
})
export class BookDetailsComponent {
  @Input() book?: BookDto;

  @Output() updateBook = new EventEmitter();
  @Output() deleteBook = new EventEmitter();

  public menuVisible = false;
  public menuOpen = false;

  public update(){
    this.updateBook.emit();
  }

  public delete(){
    this.deleteBook.emit();
  }
}
