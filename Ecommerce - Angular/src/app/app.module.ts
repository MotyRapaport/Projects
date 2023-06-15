import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { ItemsComponent } from './components/items/items.component';
import { ItemCardComponent } from './components/item-card/item-card.component';
import { BucketComponent } from './components/bucket/bucket.component';
import { AppRoutingModule } from './app-routing.module';
import { ItemPageComponent } from './pages/item-page/item-page.component';
import { Page404Component } from './components/page404/page404.component';
import { HeaderComponent } from './components/header/header.component';
import { ImgPipe } from './pipe/img.pipe';
import { SearchPipe } from './pipe/search.pipe';
import { ItemInfoComponent } from './components/item-info/item-info.component';
import { BuyComponent } from './components/buy/buy.component';
import { MessagesComponent } from './components/messages/messages.component';
import { MassegesFolderComponent } from './components/masseges-folder/masseges-folder.component';
import { FavoratesComponent } from './components/favorates/favorates.component';
import { FavorateComponent } from './components/favorate/favorate.component';
import { PricePipe } from './pipe/price.pipe';


@NgModule({
  declarations: [
    AppComponent,
    ItemsComponent,
    ItemCardComponent,
    BucketComponent,
    ItemPageComponent,
    Page404Component,
    HeaderComponent,
    ImgPipe,
    SearchPipe,
    ItemInfoComponent,
    BuyComponent,
    MessagesComponent,
    MassegesFolderComponent,
    FavoratesComponent,
    FavorateComponent,
    PricePipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
