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
    PageHeaderComponent,
    PageFooterComponent,
    PageSliderComponent,
    PageHomeComponent,
    PageShopComponent,
    PageLeftSidebarComponent,
    PageShopContentComponent,
    PageContactComponent,
    ListCategoryComponent,
    ListProductComponent,
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
import { PageHeaderComponent } from './Components/page-header/page-header.component';
import { PageFooterComponent } from './Components/page-footer/page-footer.component';
import { PageSliderComponent } from './Components/page-slider/page-slider.component';
import { PageHomeComponent } from './Components/page-home/page-home.component';
import { PageShopComponent } from './Components/page-shop/page-shop.component';
import { PageLeftSidebarComponent } from './Components/page-left-sidebar/page-left-sidebar.component';
import { PageShopContentComponent } from './Components/page-shop-content/page-shop-content.component';
import { PageContactComponent } from './Components/page-contact/page-contact.component';
import { ListCategoryComponent } from './Components/list-category/list-category.component';
import { ListProductComponent } from './Components/list-product/list-product.component';

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
