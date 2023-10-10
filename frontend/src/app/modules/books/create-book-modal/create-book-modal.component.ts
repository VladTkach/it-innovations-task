import {Component, EventEmitter, OnInit, Output} from '@angular/core';
import {MatDialogRef} from "@angular/material/dialog";
import {FormBuilder, FormGroup, Validators} from "@angular/forms";
import {CreateBookDto} from "../../../models/book/create-book-dto";
import {BookService} from "../../../core/services/book.service";
import {BaseComponent} from "../../../core/base/base.component";
import {takeUntil} from "rxjs";
import {BookDto} from "../../../models/book/book-dto";

@Component({
  selector: 'app-create-book-modal',
  templateUrl: './create-book-modal.component.html',
  styleUrls: ['./create-book-modal.component.sass']
})
export class CreateBookModalComponent extends BaseComponent implements OnInit{
  @Output() public bookCreated = new EventEmitter<BookDto>();

  public bookForm?: FormGroup;
  constructor(
    public dialogRef: MatDialogRef<CreateBookModalComponent>,
    private formBuilder: FormBuilder,
    private bookService: BookService) {
    super();
  }

  public ngOnInit() {
    this.loadForm();
  }

  public close(){
    this.dialogRef.close();
  }

  public createBook(){
    console.log(this.bookForm?.value);
    const newBook: CreateBookDto = {
      name: this.bookForm?.value.name,
      description: this.bookForm?.value.description,
      pageCount: this.bookForm?.value.pageCount
    }

    this.bookService.createBook(newBook)
      .pipe(takeUntil(this.unsubscribe$))
      .subscribe({
        next: newBook => {
          this.bookCreated.emit(newBook);
        }
      })
  }

  private loadForm(){
    this.bookForm = this.formBuilder.group({
      name: ['', Validators.required],
      description: [''],
      pageCount: [1, Validators.required],
    })
  }
}
