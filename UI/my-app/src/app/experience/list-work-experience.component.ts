import { Injectable , Input, Component, OnInit } from '@angular/core';
import { WorkexperienceService } from '../shared/workexperience.service';
import { CreateworkexperienceComponent } from './createworkexperience.component';

@Injectable({
  providedIn: 'root',
})

@Component({
  selector: 'app-list-work-experience',
  templateUrl: './list-work-experience.component.html',
  styleUrls: ['./list-work-experience.component.css']
})
export class ListWorkExperienceComponent implements OnInit {

  @Input() createUpdateWorkExperience: CreateworkexperienceComponent;
  constructor(private service : WorkexperienceService//, private createWorkExperience: CreateworkexperienceComponent
    ) { }

  ngOnInit() {
    this.service.getWorkExperience();
  }

  openCreateProfessionalExperience(){
    this.createUpdateWorkExperience.opens('new');
  }
  
  openUpdateProfessionalExperience(){
    this.createUpdateWorkExperience.opens('update');
  }
}
