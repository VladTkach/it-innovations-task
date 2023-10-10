import {Component, Input} from '@angular/core';
import {BookDto} from "../../../models/book/book-dto";

@Component({
  selector: 'app-book-details',
  templateUrl: './book-details.component.html',
  styleUrls: ['./book-details.component.sass']
})
export class BookDetailsComponent {
  @Input() book?: BookDto;
}
