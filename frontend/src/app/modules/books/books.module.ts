import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';

import {BooksRoutingModule} from './books-routing.module';
import {BooksPageComponent} from './books-page/books-page.component';
import {BookDetailsComponent} from './book-details/book-details.component';
import {MaterialModule} from "../../material/material.module";
import {CreateBookModalComponent} from './create-book-modal/create-book-modal.component';
import {ReactiveFormsModule} from "@angular/forms";


@NgModule({
  declarations: [
    BooksPageComponent,
    BookDetailsComponent,
    CreateBookModalComponent
  ],
  imports: [
    CommonModule,
    BooksRoutingModule,
    MaterialModule,
    ReactiveFormsModule
  ]
})
export class BooksModule {
}
