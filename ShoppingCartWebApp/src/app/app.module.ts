import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PageShopComponent } from './page-shop/page-shop.component';
import { ListCategoryComponent } from './page-shop/list-category/list-category.component';
import { DataServiceService } from './shared/data-service.service';
import { HttpClientModule } from '@angular/common/http';
import { ListProductComponent } from './page-shop/list-product/list-product.component';
import { PageHeaderComponent } from './page-header/page-header.component';
import { PageFooterComponent } from './page-footer/page-footer.component';

@NgModule({
  declarations: [AppComponent, PageShopComponent, ListCategoryComponent, ListProductComponent, PageHeaderComponent, PageFooterComponent],
  imports: [BrowserModule, AppRoutingModule, HttpClientModule],
  providers: [DataServiceService],
  bootstrap: [AppComponent],
})
export class AppModule {}
