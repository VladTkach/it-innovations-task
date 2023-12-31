import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavbarComponent } from './components/navbar/navbar.component';
import {RouterLink, RouterLinkActive} from "@angular/router";



@NgModule({
    declarations: [
        NavbarComponent
    ],
    exports: [
        NavbarComponent
    ],
  imports: [
    CommonModule,
    RouterLink,
    RouterLinkActive
  ]
})
export class SharedModule { }
