import { Component, OnInit } from '@angular/core';
import { EducationexperienceService } from '../shared/educationexperience.service';
import { Educationexperience } from '../shared/educationexperience.model';


@Component({
  selector: 'app-list-education-experience',
  templateUrl: './list-education-experience.component.html',
  styleUrls: ['./list-education-experience.component.css']
})
export class ListEducationExperienceComponent implements OnInit {

  constructor(private service : EducationexperienceService) { }
  listEducationExperienceObservable: Educationexperience[];
  

  ngOnInit() {
    //this.service.getEducationExperience();
    //using observable
    this.service.getEducationExperienceObservable().subscribe(data => this.listEducationExperienceObservable = data);
  
  }

}
