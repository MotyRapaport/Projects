import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import {ItemsComponent} from './components/items/items.component';
import { Page404Component } from './components/page404/page404.component';
import { ItemPageComponent } from "./pages/item-page/item-page.component"
import { BuyComponent } from './components/buy/buy.component';
import { FavoratesComponent } from './components/favorates/favorates.component';
const routes: Routes = [
  { path: '', component: ItemsComponent},
  {path: 'home', component: ItemsComponent},
 {path: 'favorates', component: FavoratesComponent},
  {path: 'buy', component: BuyComponent},
  {path: '404', component: Page404Component},
  {path: 'items/:id', component: ItemPageComponent},
  {path: '**', redirectTo: '404'}
  ];
  

@NgModule({
  declarations: [],
  imports: [
    CommonModule, RouterModule.forRoot(routes),
  ],
  exports:[RouterModule]
})
export class AppRoutingModule { }
