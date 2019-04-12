import { Component, OnInit } from '@angular/core';
import { EducationexperienceService } from '../shared/educationexperience.service';


@Component({
  selector: 'app-list-education-experience',
  templateUrl: './list-education-experience.component.html',
  styleUrls: ['./list-education-experience.component.css']
})
export class ListEducationExperienceComponent implements OnInit {

  constructor(private service : EducationexperienceService) { }

  ngOnInit() {
    this.service.getEducationExperience();
  }

}
