import { Component, OnInit } from '@angular/core';
import { WorkexperienceService } from '../shared/workexperience.service';

@Component({
  selector: 'app-list-work-experience',
  templateUrl: './list-work-experience.component.html',
  styleUrls: ['./list-work-experience.component.css']
})
export class ListWorkExperienceComponent implements OnInit {

  constructor(private service : WorkexperienceService) { }

  ngOnInit() {
    this.service.getWorkExperience();
  }

}
