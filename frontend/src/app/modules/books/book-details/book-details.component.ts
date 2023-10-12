import {Component, EventEmitter, Input, Output} from '@angular/core';
import {BookDto} from "../../../models/book/book-dto";

@Component({
  selector: 'app-book-details',
  templateUrl: './book-details.component.html',
  styleUrls: ['./book-details.component.sass']
})
export class BookDetailsComponent {
  @Input() book?: BookDto;
  @Input() selected?: boolean;

  @Output() updateBook = new EventEmitter();
  @Output() deleteBook = new EventEmitter();
  @Output() selectBook: EventEmitter<void> = new EventEmitter<void>();

  public menuVisible = false;
  public menuOpen = false;

  public update(){
    this.updateBook.emit();
  }

  public delete(){
    this.deleteBook.emit();
  }

  selectBookHandler(): void {
    this.selectBook.emit();
  }

  menuClick($event: MouseEvent) {
    this.menuOpen = true;
    $event.stopPropagation();
  }
}
