import {Component, EventEmitter, Inject, OnInit, Output} from '@angular/core';
import {MAT_DIALOG_DATA, MatDialogRef} from "@angular/material/dialog";
import {FormBuilder, FormGroup, Validators} from "@angular/forms";
import {CreateBookDto} from "../../../models/book/create-book-dto";
import {BookService} from "../../../core/services/book.service";
import {BaseComponent} from "../../../core/base/base.component";
import {takeUntil} from "rxjs";
import {BookDto} from "../../../models/book/book-dto";
import {UpdateBookDto} from "../../../models/book/update-book-dto";
import {DateFormatter} from "../../../shared/heplers/date-formatter";

@Component({
  selector: 'app-create-book-modal',
  templateUrl: './create-book-modal.component.html',
  styleUrls: ['./create-book-modal.component.sass']
})
export class CreateBookModalComponent extends BaseComponent implements OnInit{
  @Output() public bookCreated = new EventEmitter<BookDto>();

  public bookForm?: FormGroup;

  public isUpdate = false;

  public updateBook?: UpdateBookDto;
  constructor(
    public dialogRef: MatDialogRef<CreateBookModalComponent>,
    private formBuilder: FormBuilder,
    private bookService: BookService,
    @Inject(MAT_DIALOG_DATA) public data: { isUpdate: boolean, updateBook: UpdateBookDto}) {
    super();
    this.isUpdate = data.isUpdate;
    this.updateBook = data.updateBook;
  }

  public ngOnInit() {
    this.loadForm();
  }

  public close(){
    this.dialogRef.close();
  }

  public create(){
    const newBook: CreateBookDto = {
      name: this.bookForm?.value.name,
      description: this.bookForm?.value.description,
      pageCount: this.bookForm?.value.pageCount,
      createdAt: DateFormatter.formatDate(this.bookForm?.value.createdAt)
    }

    this.bookService.createBook(newBook)
      .pipe(takeUntil(this.unsubscribe$))
      .subscribe({
        next: newBook => {
          this.bookCreated.emit(newBook);
        }
      })
  }

  public update(){
    console.log(this.bookForm?.value);
    if (!this.updateBook){
      return;
    }

    this.updateBook.name = this.bookForm?.value.name;
    this.updateBook.description = this.bookForm?.value.description;
    this.updateBook.pageCount = this.bookForm?.value.pageCount;
    this.updateBook.createdAt = DateFormatter.formatDate(this.bookForm?.value.createdAt);

    this.bookService.updateBook(this.updateBook)
      .pipe(takeUntil(this.unsubscribe$))
      .subscribe({
        next: newBook => {
          this.bookCreated.emit(newBook);
        }
      })
  }

  private loadForm(){
    this.bookForm = this.formBuilder.group({
      name: [this.updateBook ? this.updateBook.name : '', Validators.required],
      description: [this.updateBook ? this.updateBook.description : ''],
      pageCount: [this.updateBook ? this.updateBook.pageCount : 1, Validators.required],
      createdAt: [this.updateBook ? this.updateBook.createdAt : new Date(), Validators.required]
    })
  }
}
