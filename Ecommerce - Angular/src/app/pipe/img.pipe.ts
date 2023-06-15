import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'img'
})
export class ImgPipe implements PipeTransform {

  transform(img:string): string {
    return "../../assets/img/" + img;
  }

}
