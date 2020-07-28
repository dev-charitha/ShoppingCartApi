import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PageShopComponent } from './page-shop/page-shop.component';
import { PageHomeComponent } from './page-home/page-home.component';
import { PageRegisterComponent } from './page-register/page-register.component';
import { PageLoginComponent } from './page-login/page-login.component';
import { AuthGuard } from './auth/auth.guard';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  { path: '', redirectTo: 'pageshop', pathMatch: 'full' },
  { path: 'pagehome', component: PageHomeComponent },
  { path: 'pageshop', component: PageShopComponent },
  { path: 'pageregister', component: PageRegisterComponent },
  { path: 'pagelogin', component: PageLoginComponent },
  { path: 'home', component: HomeComponent, canActivate: [AuthGuard] },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
