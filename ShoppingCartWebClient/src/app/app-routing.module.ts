import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProductComponent } from './product/product.component';
//import { CategoryComponent } from './category/category.component';
//import { AddComponent } from './category/add/add.component';

const routes: Routes = [
  { path: '', redirectTo: 'product', pathMatch: 'full' },
  {
    path: 'product',
    component: ProductComponent,
    //children: [{ path: 'add', component: AddComponent }],
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
