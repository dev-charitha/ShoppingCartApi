import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './Components/home/home.component';
import { AboutComponent } from './Components/about/about.component';
import { ContactComponent } from './Components/contact/contact.component';
import { ShopComponent } from './Components/shop/shop.component';
import { ItemComponent } from './Components/shop/item/item.component';
import { from } from 'rxjs';

const routes: Routes = [
  {
    path: 'home',
    component: HomeComponent,
  },
  {
    path: 'about',
    component: AboutComponent,
  },
  {
    path: 'contact',
    component: ContactComponent,
  },
  {
    path: 'shop',
    component: ShopComponent,
  },
  //{
  //  path: '',
  //  redirectTo: '/home',
  //  pathMatch: 'full',
  //},
  //{
  //  path: '**',
  //  redirectTo: '/home',
  //  pathMatch: 'full',
  //},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
