import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PageShopComponent } from './page-shop/page-shop.component';
import { DataServiceService } from './shared/data-service.service';
import { HttpClientModule } from '@angular/common/http';
import { PageHeaderComponent } from './page-header/page-header.component';
import { PageFooterComponent } from './page-footer/page-footer.component';

@NgModule({
  declarations: [
    AppComponent,
    PageShopComponent,
    PageHeaderComponent,
    PageFooterComponent,
  ],
  imports: [BrowserModule, AppRoutingModule, HttpClientModule],
  providers: [DataServiceService],
  bootstrap: [AppComponent],
})
export class AppModule {}
