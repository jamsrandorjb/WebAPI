import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Workexperience } from './workexperience.model';


@Injectable({
  providedIn: 'root'
})
export class WorkexperienceService {
  
  readonly rootUrl = 'http://localhost:62745/api/';
  listWorkExperience: Workexperience[];
  constructor(private http: HttpClient) { }

  getWorkExperience(){
    this.http.get(this.rootUrl+'workexperience/get')
    .toPromise().then(res => this.listWorkExperience = res as Workexperience[]);
  }
}
