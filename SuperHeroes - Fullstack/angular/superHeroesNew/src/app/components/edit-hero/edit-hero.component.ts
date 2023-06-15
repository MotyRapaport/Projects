import { Component, EventEmitter, Input, Output } from '@angular/core';
import { SuperHeroes } from 'src/app/models/superHeroes';
import { SuperHeroesService } from 'src/app/services/super-heroes.service';

@Component({
  selector: 'app-edit-hero',
  templateUrl: './edit-hero.component.html',
  styleUrls: ['./edit-hero.component.css']
})
export class EditHeroComponent {
@Input() hero?: SuperHeroes;
@Output() heroesUpdated = new EventEmitter<SuperHeroes[]>();
constructor(private heroesService: SuperHeroesService){
}
deleteHero(hero:SuperHeroes){
this.heroesService.deleteSuperHeroes(hero).subscribe(
  (heroes: SuperHeroes[]) => this.heroesUpdated.emit(heroes)
  );
}

createHero(hero:SuperHeroes){
this.heroesService.createSuperHeroes(hero).subscribe(
  (heroes: SuperHeroes[]) => this.heroesUpdated.emit(heroes)
)
}

updateHero(hero:SuperHeroes){
this.heroesService.updateSuperHeroes(hero).subscribe(
  (heroes: SuperHeroes[]) => this.heroesUpdated.emit(heroes)
  )
}

}
