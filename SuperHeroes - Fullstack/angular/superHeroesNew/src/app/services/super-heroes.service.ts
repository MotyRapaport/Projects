import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, concat, Observable,  } from 'rxjs';
import { environment } from 'src/environments/environment';
import { SuperHeroes } from '../models/superHeroes';

@Injectable({
  providedIn: 'root'
})
export class SuperHeroesService {
url = "SuperHeroes";
  constructor(private http: HttpClient) { }

  public getSuperHeroes(): Observable<SuperHeroes[]> {
    return this.http.get<SuperHeroes[]>(`${environment.apiUrl}/${this.url}`);
    
  }

  public updateSuperHeroes(hero: SuperHeroes): Observable<SuperHeroes[]> {
    return this.http.put<SuperHeroes[]>(`${environment.apiUrl}/${this.url}`, hero);
    
  }

  public createSuperHeroes(hero: SuperHeroes): Observable<SuperHeroes[]> {
    return this.http.post<SuperHeroes[]>(`${environment.apiUrl}/${this.url}`, hero);
    
  }

  public deleteSuperHeroes(hero: SuperHeroes): Observable<SuperHeroes[]> {
    return this.http.delete<SuperHeroes[]>(`${environment.apiUrl}/${hero.id}`);
    
  }
}
