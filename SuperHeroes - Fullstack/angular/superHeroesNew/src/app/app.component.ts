import { Component } from '@angular/core';
import { SuperHeroes } from './models/superHeroes';
import { SuperHeroesService } from './services/super-heroes.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'superHeroes-UI';
  Heroes:  SuperHeroes[];
editNewHero?: SuperHeroes;

  constructor(private superHeroes: SuperHeroesService){
    this.Heroes = [];
   }

  ngOnInit(): void{
  this.superHeroes.getSuperHeroes().subscribe((result: SuperHeroes[]) => this.Heroes = result);
  }

  addNewHero(){
    this.editNewHero = new SuperHeroes();
  }

  edit(hero: SuperHeroes){
    this.editNewHero = hero;
  }

  UpdateHeroesList(HeroesList: SuperHeroes[]){
    this.Heroes = HeroesList;
  }
  
}


