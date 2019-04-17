import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
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
import { GithubComponent } from './social/github/github.component';
import { OrderModule } from 'ngx-order-pipe';



@NgModule({
  declarations: [
    AppComponent,
    ListWorkExperienceComponent,
    ListEducationExperienceComponent,
    CreateworkexperienceComponent,
    CreateeducationexperienceComponent,
    NgbdModalNew, 
    NgbdModalUpdate, 
    GithubComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    NgbModule,
    FormsModule,
    OrderModule
  ],
  entryComponents: [NgbdModalNew, NgbdModalUpdate],
  providers: [WorkexperienceService],
  bootstrap: [AppComponent]
})
export class AppModule { }





