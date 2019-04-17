import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListWorkExperienceComponent } from './experience/list-work-experience.component';
import { ListEducationExperienceComponent } from './experience/list-education-experience.component';
import { CreateworkexperienceComponent } from './experience/createworkexperience.component';
import { CreateeducationexperienceComponent } from './experience/createeducationexperience.component';
import { WorkexperienceService } from './shared/workexperience.service';
import {
  NgbdModalNew,
  NgbdModalUpdate
} from './experience/createworkexperience.component';



@NgModule({
  declarations: [
    AppComponent,
    ListWorkExperienceComponent,
    ListEducationExperienceComponent,
    CreateworkexperienceComponent,
    CreateeducationexperienceComponent,
    NgbdModalNew, 
    NgbdModalUpdate
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    NgbModule
  ],
  entryComponents: [NgbdModalNew, NgbdModalUpdate],
  providers: [WorkexperienceService],
  bootstrap: [AppComponent]
})
export class AppModule { }





