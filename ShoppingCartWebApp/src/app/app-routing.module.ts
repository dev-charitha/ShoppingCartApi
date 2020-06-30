import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PageShopComponent } from './page-shop/page-shop.component';
import { ListCategoryComponent } from './page-shop/list-category/list-category.component';
import { ListProductComponent } from './page-shop/list-product/list-product.component';

const routes: Routes = [
  //{ path: '', redirectTo: '/pageshop/listcategory', pathMatch: 'full' },
  { path: '', redirectTo: 'pageshop', pathMatch: 'full' },
  {
    path: 'pageshop',
    component: PageShopComponent,
    children: [
      //{ path: '', redirectTo: 'listcategory', pathMatch: 'full' },
      { path: 'listcategory', component: ListCategoryComponent },
      { path: 'listproduct', component: ListProductComponent },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
