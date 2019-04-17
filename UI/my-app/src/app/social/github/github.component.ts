import { Component, OnInit } from '@angular/core';
import { SocialService } from 'src/app/shared/social.service';
import { Github } from 'src/app/shared/github.model';
import { OrderPipe } from 'ngx-order-pipe';

@Component({
  selector: 'app-github',
  templateUrl: './github.component.html',
  styleUrls: ['./github.component.css']
})
export class GithubComponent implements OnInit {

  constructor(private service : SocialService, private orderPipe: OrderPipe) { }
  listGithubRepos:Github[];
  githubuser:string;
  ngOnInit() {
    this.githubuser='jamsrandorjb';
    //this.service.getPublicRepos(this.githubuser);
    this.service.getPublicReposObservable(this.githubuser).subscribe(data => this.listGithubRepos = this.orderPipe.transform(data, 'created_at'));
  }

}




