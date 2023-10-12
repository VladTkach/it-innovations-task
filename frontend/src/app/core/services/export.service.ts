import { Injectable } from '@angular/core';
import * as XLSX from 'xlsx';
import { jsPDF} from "jspdf";
import autoTable from "jspdf-autotable";
import {BookDto} from "../../models/book/book-dto";

@Injectable({
  providedIn: 'root'
})
export class ExportService {
  public exportExcel(books: BookDto[]) {
    const ws: XLSX.WorkSheet = XLSX.utils.json_to_sheet(books);
    const wb: XLSX.WorkBook = XLSX.utils.book_new();
    XLSX.utils.book_append_sheet(wb, ws, 'Books');
    XLSX.writeFile(wb, 'Books.xlsx');
  }

  public exportPDF(books: BookDto[]){
    var doc = new jsPDF();
    var col = ["Id", "Name", "Description", "Page count", "Crated At"];
    var rows: any[] = [];

    books.forEach(element => {
      var temp = [element.id, element.name, element.description, element.pageCount, element.createdAt];
      rows.push(temp);

    });

    autoTable(doc,{
      head: [col],
      body: rows
    })
    doc.save('Books.pdf');
  }
}
