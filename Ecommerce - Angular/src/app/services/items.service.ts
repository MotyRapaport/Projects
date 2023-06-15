import { Injectable } from '@angular/core';
import { Bucket } from '../Models/bucket';
import { Items } from '../Models/items';

@Injectable({
  providedIn: 'root'
})
export class ItemsService {
  itemsArr!: Items[];
 private buck!:Bucket[];
  constructor() {
    this.itemsArr = [{ Name: "Wine", Id: "111", Qty: 2, Discription: "Very tasty wine!", Catagory: "winary", Active: true, Img: "wine-img.jpg", price: 150 },
    { Name: "Milk", Id: "222", Qty: 3, Discription: "The best milk from Tenuvah", Catagory: "Dairy", Active: false, Img: "milk2.webp", price: 5.90 },
    { Name: "Bisli", Id: "333", Qty: 0, Discription: "The best snack from Osem!", Catagory: "Snacks", Active: true, Img: "Bisli.jpg", price: 4 },
    {Name: "Shoko", Id: "444", Qty: 3, Discription: "Less suger, better taste", Catagory: "Dairy", Active: true, Img: "shoko.jpg", price: 5},
    {Name: "Flour", Id: "555", Qty: 3, Discription: "High quality flour!!!", Catagory: "Baking", Active: true, Img: "kemach.jpg", price: 10},
    {Name: "Coke", Id: "666", Qty: 3, Discription: "Ice cold and fresh!!", Catagory: "Drinks", Active: true, Img: "coke.jpg", price: 8},  
    {Name: "Jump", Id: "777", Qty: 3, Discription: "Your best choice!! Go for it!", Catagory: "Drinks", Active: true, Img: "jump.jpg", price: 11},
    {Name: "Koteg", Id: "999", Qty: 3, Discription: "American taste!! Try it!!", Catagory: "Dairy", Active: true, Img: "koteg.jpg", price: 5}
    ];
   
   
  this.buck = JSON.parse(localStorage.getItem('favorates') ?? '[]');
  
  }

  getItems(): Items[] {
    return this.itemsArr;
  }
  getSpecificItem(id: string):Items {
    return this.itemsArr.find(f => f.Id == id)!;
  }
  reductItem(item:Items){
    if(item.Qty > 0)
      item.Qty--;
    console.log(item.Qty);
  }
  incItem(item:Items){
    item.Qty++;
    console.log(item.Qty + " increase");
  }
  addToFav(bucket: Bucket){
   let find = this.buck.find(f => f.Id  == bucket.Id)!;
   if(find == undefined){
    this.buck.push(bucket);
   }
   else{
    find.buyingQnt++;
   }
   localStorage.setItem('favorates', JSON.stringify(this.buck));
  }
  returnFav():Bucket[]{
    return this.buck;
  }
  
}
