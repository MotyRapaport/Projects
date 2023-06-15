import { Component, OnInit } from '@angular/core';
import { Bucket } from 'src/app/Models/bucket';
import { BucketService } from 'src/app/services/bucket.service';
import { VariablesService } from 'src/app/services/variables.service';

@Component({
  selector: 'app-bucket',
  templateUrl: './bucket.component.html',
  styleUrls: ['./bucket.component.css']
})
export class BucketComponent implements OnInit {

  bucket:Bucket[];
  totalSum: {buckt: number};
  constructor(private bucketService: BucketService, private variableService: VariablesService) {
    this.bucket = this.bucketService.getBucket();
   this.totalSum = this.bucketService.returnTotalSum();
   }

  ngOnInit(): void {
  }

toggle(){
this.variableService.toggleOpenBucket();
}
}
