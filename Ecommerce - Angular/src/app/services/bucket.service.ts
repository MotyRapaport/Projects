import { Injectable } from '@angular/core';
import { Bucket } from '../Models/bucket';
import { Items } from '../Models/items';
import { Message, MessageType } from '../Models/message';
import { ItemsService } from './items.service';
import { MessageService } from './message.service';
import { VariablesService } from './variables.service';

@Injectable({
  providedIn: 'root'
})
export class BucketService {

  bucket!: Bucket[];
  totalSum!: { buckt: number };
  constructor(private variableServices: VariablesService, private itemsService: ItemsService, private MsgService:MessageService) {
    this.bucket = [];
    this.totalSum = { buckt: 0 };
  }
  addToBucket(item: Items): void {
    let itm = this.bucket.find(f => f.Id == item.Id); // בודק אם המוצר נמצא כבר בסל
    if (itm == undefined) { // אם לא נמצא בסל, הוסף אותו
      if (item.Qty > 0) {
        var bckt: Bucket = { buyingQnt: 1, Id: item.Id, Img: item.Img, Name: item.Name, Qty: item.Qty, Discription: item.Discription, Catagory: item.Catagory, Active: item.Active, price: item.price };
        bckt.sumOfItem = bckt.price;
        this.bucket.push(bckt);
        this.variableServices.openBucketTrue();
        let msg:Message = {Topic: "Success", Subject: "Your item was added", Type: MessageType.Success};
        this.MsgService.setMessage(msg); 
      }


    }
    else {
      if (item.Qty > 0) {
        itm.buyingQnt++;
        itm.sumOfItem = itm.buyingQnt * itm.price;
        let msg:Message = {Topic: "Finished Successfully!", Subject: "Your item was added", Type: MessageType.Success};
        this.MsgService.setMessage(msg); 
      } // אם נמצא בסל, הוסף לכמות

    }
   this.setTotalSum();
  }
  setTotalSum(){
    this.totalSum.buckt = 0;
    this.bucket.forEach(element => {
      this.totalSum.buckt += element.sumOfItem!;
    });
  }
  returnTotalSum(): { buckt: number } {
    return this.totalSum;
  }
  getBucket(): Bucket[] {
    return this.bucket;
  }
  removeItm(item: Items) {
    let bucketItem = this.bucket.find(f => f.Id == item.Id); // למצוא את המוצר בסל
    if(bucketItem != undefined){
      if (bucketItem!.buyingQnt > 1) { // אם גדול מ-1, הורד כמות, ועדכן מלאי
        bucketItem!.buyingQnt--;
        this.itemsService.incItem(item);
        this.setTotalSum();
      }
      else { // אם יש רק אחד
        let index = this.bucket.findIndex(f => f.Id == bucketItem?.Id);
        this.bucket.splice(index, 1);
        this.itemsService.incItem(item);
        this.setTotalSum();
      }
    }
   
  }
}
