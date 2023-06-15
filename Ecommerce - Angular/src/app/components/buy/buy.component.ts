import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Bucket } from 'src/app/Models/bucket';
import { Items } from 'src/app/Models/items';
import { BucketService } from 'src/app/services/bucket.service';

@Component({
  selector: 'app-buy',
  templateUrl: './buy.component.html',
  styleUrls: ['./buy.component.css']
})
export class BuyComponent implements OnInit {
  bucket:Bucket[];
  totalSum: {buckt: number};
  @Output() buttonClicked = new EventEmitter<Items>();
@Output() buttonDec = new EventEmitter<Items>();

  constructor(private bucketService: BucketService) {
    this.bucket = this.bucketService.getBucket();
    this.totalSum = this.bucketService.returnTotalSum();
   }

  ngOnInit(): void {
  }
  clickInc(){
    this.buttonClicked.emit(this.bucket as unknown as Items);
  }
  clickDec(){
this.buttonDec.emit(this.bucket as unknown as Items);
  }
}
