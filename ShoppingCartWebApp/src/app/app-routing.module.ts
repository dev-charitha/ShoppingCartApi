import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PageShopComponent } from './page-shop/page-shop.component';
import { PageHomeComponent } from './page-home/page-home.component';
import { PageRegisterComponent } from './page-register/page-register.component';

const routes: Routes = [
  { path: '', redirectTo: 'pageshop', pathMatch: 'full' },
  { path: 'pagehome', component: PageHomeComponent },
  { path: 'pageshop', component: PageShopComponent },
  { path: 'pageregister', component: PageRegisterComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
