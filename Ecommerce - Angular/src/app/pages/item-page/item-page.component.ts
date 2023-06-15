import { Component, OnInit } from '@angular/core';
import { Items } from 'src/app/Models/items';
import { ActivatedRoute } from '@angular/router';
import { ItemsService } from 'src/app/services/items.service';
import { Router } from '@angular/router';
import { BucketService } from 'src/app/services/bucket.service';
import { ItemCardComponent } from 'src/app/components/item-card/item-card.component';
@Component({
  selector: 'app-item-page',
  templateUrl: './item-page.component.html',
  styleUrls: ['./item-page.component.css']
})
export class ItemPageComponent implements OnInit {
  itm!: Items;
  id!: string;
  constructor(private route: ActivatedRoute, private itemsService: ItemsService, private router: Router, private bucketService: BucketService) {
    this.id = this.route.snapshot.paramMap.get('id')!;
    this.itm = this.itemsService.getSpecificItem(this.id);
    if (this.itm != undefined) {

    }
    else {
      this.router.navigate(['404']);
    }
  }

  ngOnInit(): void {
  }


  addItem(item: Items) {
    this.bucketService.addToBucket(item);
  
  }
}
