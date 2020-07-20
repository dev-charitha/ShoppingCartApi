import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
//import { ReactiveFormsModule } from '@angular/forms';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PageShopComponent } from './page-shop/page-shop.component';
import { DataServiceService } from './shared/data-service.service';
import { PageHeaderComponent } from './page-header/page-header.component';
import { PageFooterComponent } from './page-footer/page-footer.component';
import { PageHomeComponent } from './page-home/page-home.component';
import { PageRegisterComponent } from './page-register/page-register.component';

@NgModule({
  declarations: [
    AppComponent,
    PageShopComponent,
    PageHeaderComponent,
    PageFooterComponent,
    PageHomeComponent,
    PageRegisterComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  providers: [DataServiceService],
  bootstrap: [AppComponent],
})
export class AppModule {}
