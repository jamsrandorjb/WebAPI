import { Injectable } from '@angular/core';
import { Person } from './person.model';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PersonService {
  readonly rootUrl = 'http://localhost:62745/api/';
  person: Person;

  constructor(private http: HttpClient) { }

  getPersonById(Id){
    this.http.get(this.rootUrl+'api/People?Id='+Id)
    .toPromise().then(res => this.person = res as Person);
  }
  //using observable
  getPersonByIdObservable(Id) : Observable<Person>{
    return this.http.get<Person>(this.rootUrl+'api/People?Id='+Id);
  }

}