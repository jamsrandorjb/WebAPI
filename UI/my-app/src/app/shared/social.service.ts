import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Github } from './github.model';
import { OrderPipe } from 'ngx-order-pipe';

@Injectable({
  providedIn: 'root'
})
export class SocialService {

  readonly rootUrl = 'https://api.github.com/';
  lisGithubRepo: Github[];
  constructor(private http: HttpClient, private orderPipe: OrderPipe) { }

  //promises
  getPublicRepos(id){
    this.http.get(this.rootUrl+'users/'+id+'/repos')
    .toPromise().then(res => this.lisGithubRepo = res as Github[]);
  }
  //observable
  getPublicReposObservable(id) : Observable<Github[]>{
    return this.http.get<Github[]>(this.rootUrl+'users/'+id+'/repos');
  
  }

  
}
