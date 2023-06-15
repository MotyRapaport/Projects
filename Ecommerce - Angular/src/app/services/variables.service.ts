import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class VariablesService {

  searchItem: { search: string};
  openBucket: {open: boolean};
  isMsg: {opacity: boolean};
  constructor() { 
    this.searchItem = {search: ""};
    this.openBucket = { open: false};
    this.isMsg = {opacity: false};
  }

  returnSearchItem():{search: string}{
return this.searchItem;
  }
  getSearchItem(search: string):void{
    this.searchItem.search = search;
  }
  toggleOpenBucket(){
    this.openBucket.open =! this.openBucket.open;
  }

  returnOpenBucket(){
    return this.openBucket;
  }
  openBucketTrue(){
    this.openBucket.open = true;
  }
  opacityFalse(){
    this.isMsg.opacity = false;
  }
  opacityTrue(){
    this.isMsg.opacity = true;
  }

  returnOpacity(){
    return this.isMsg;
  }

}
