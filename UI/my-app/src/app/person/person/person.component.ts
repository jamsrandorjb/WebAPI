import { Component, OnInit } from '@angular/core';
import { PersonService } from 'src/app/shared/person.service';
import { Person } from 'src/app/shared/person.model';

@Component({
  selector: 'app-person',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.css']
})
export class PersonComponent implements OnInit {

  constructor(private service : PersonService) { }
  personInfo : Person;

  ////using observable
  ngOnInit() {
    this.service.getPersonByIdObservable(1)
    .subscribe(data => this.personInfo = data);;
  }

}
