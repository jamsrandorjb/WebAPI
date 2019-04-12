import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListEducationExperienceComponent } from './list-education-experience.component';

describe('ListEducationExperienceComponent', () => {
  let component: ListEducationExperienceComponent;
  let fixture: ComponentFixture<ListEducationExperienceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListEducationExperienceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListEducationExperienceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
