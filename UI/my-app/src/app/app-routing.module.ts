import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListWorkExperienceComponent } from './experience/list-work-experience.component';
import { ListEducationExperienceComponent } from './experience/list-education-experience.component';


const routes: Routes = [
  { path: 'listworkexperience', component: ListWorkExperienceComponent },
  { path: 'listeducationexperience', component: ListEducationExperienceComponent }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
