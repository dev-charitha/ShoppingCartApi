import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProductComponent } from './product/product.component';
//import { CategoryComponent } from './category/category.component';
//import { AddComponent } from './category/add/add.component';
import { PageHomeComponent } from './Components/page-home/page-home.component';
import { PageShopComponent } from './Components/page-shop/page-shop.component';
import { PageContactComponent } from './Components/page-contact/page-contact.component';

const routes: Routes = [
  //{ path: '', redirectTo: 'product', pathMatch: 'full' },
  //{
  //  path: 'product',
  //  component: ProductComponent,
  //  //children: [{ path: 'add', component: AddComponent }],
  //},
  {
    path: 'home',
    component: PageHomeComponent,
  },
  {
    path: 'contact',
    component: PageContactComponent,
  },
  {
    path: 'shop',
    component: PageShopComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
