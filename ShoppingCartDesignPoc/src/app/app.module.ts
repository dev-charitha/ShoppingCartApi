import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TemplateHeaderComponent } from './Components/template-header/template-header.component';
import { TemplateFooterComponent } from './Components/template-footer/template-footer.component';
import { TemplateSliderComponent } from './Components/template-slider/template-slider.component';
import { HomeComponent } from './Components/home/home.component';
import { AboutComponent } from './Components/about/about.component';
import { ContactComponent } from './Components/contact/contact.component';
import { ShopComponent } from './Components/shop/shop.component';
import { CategoryComponent } from './Components/category/category.component';
import { ProductComponent } from './Components/product/product.component';
import { ProductDetailsComponent } from './Components/product-details/product-details.component';
import { LeftSidebarComponent } from './Components/left-sidebar/left-sidebar.component';
import { ShopContentComponent } from './Components/shop-content/shop-content.component';
import { ProductDetailsContentComponent } from './Components/product-details-content/product-details-content.component';
import { ItemComponent } from './Components/shop/item/item.component';

@NgModule({
  declarations: [
    AppComponent,
    TemplateHeaderComponent,
    TemplateFooterComponent,
    TemplateSliderComponent,
    HomeComponent,
    AboutComponent,
    ContactComponent,
    ShopComponent,
    CategoryComponent,
    ProductComponent,
    ProductDetailsComponent,
    LeftSidebarComponent,
    ShopContentComponent,
    ProductDetailsContentComponent,
    ItemComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
