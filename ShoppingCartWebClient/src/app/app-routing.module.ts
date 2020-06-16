import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CategoryComponent } from './category/category.component';
import { AddComponent } from './category/add/add.component';

const routes: Routes = [
  { path: '', redirectTo: 'category/add', pathMatch: 'full' },
  {
    path: 'category',
    component: CategoryComponent,
    children: [{ path: 'add', component: AddComponent }],
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
