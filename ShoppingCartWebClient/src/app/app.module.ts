import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CategoryComponent } from './category/category.component';
import { AddComponent } from './category/add/add.component';
import { CategoryService } from './shared/category.service';
import { ProductComponent } from './product/product.component';
import { ProductList } from './product/shop/productList.component';
import { DataService } from './product/shop/shared/dataService';

@NgModule({
  declarations: [
    AppComponent,
    CategoryComponent,
    AddComponent,
    ProductComponent,
    ProductList,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
  ],
  //providers: [CategoryService],
  providers: [DataService],
  bootstrap: [AppComponent],
})
export class AppModule {}

//------------------------------------

//import { BrowserModule } from '@angular/platform-browser';
//import { NgModule } from '@angular/core';
//import {HttpClientModule, HttpClient} from '@angular/common/http';

//import { AppComponent } from './app.component';
import { from } from 'rxjs';

//import { EmployeeListComponent } from './employee-list/employee-list.component';

//@NgModule({
//  declarations: [
//    AppComponent,
//    EmployeeListComponent
//  ],
// imports: [
//   BrowserModule,
//   HttpClientModule
// ],
// providers: [],
//  bootstrap: [AppComponent]
//})
//export class AppModule { }
