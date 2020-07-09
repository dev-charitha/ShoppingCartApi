import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PageShopComponent } from './page-shop/page-shop.component';

const routes: Routes = [
  { path: '', redirectTo: 'pageshop', pathMatch: 'full' },
  { path: 'pageshop', component: PageShopComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
