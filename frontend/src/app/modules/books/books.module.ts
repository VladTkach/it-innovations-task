import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';

import {BooksRoutingModule} from './books-routing.module';
import {BooksPageComponent} from './books-page/books-page.component';
import {BookDetailsComponent} from './book-details/book-details.component';
import {MaterialModule} from "../../material/material.module";
import {BookModalComponent} from './book-modal/book-modal.component';
import {FormsModule, ReactiveFormsModule} from "@angular/forms";


@NgModule({
  declarations: [
    BooksPageComponent,
    BookDetailsComponent,
    BookModalComponent
  ],
    imports: [
        CommonModule,
        BooksRoutingModule,
        MaterialModule,
        ReactiveFormsModule,
        FormsModule
    ]
})
export class BooksModule {
}
