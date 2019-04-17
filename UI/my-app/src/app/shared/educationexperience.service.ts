import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Educationexperience } from './educationexperience.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EducationexperienceService {

  readonly rootUrl = 'http://localhost:62745/api/';
  listEducationExperience: Educationexperience[];
  constructor(private http: HttpClient) { }
  getEducationExperience(){
    this.http.get(this.rootUrl+'EducationExperiences/GetEducationExperience')
    .toPromise().then(res => this.listEducationExperience = res as Educationexperience[]);
  }
  //using observable
  getEducationExperienceObservable() : Observable<Educationexperience[]>{
    return this.http.get<Educationexperience[]>(this.rootUrl+'EducationExperiences/GetEducationExperience');
  }
}






