import { TestBed } from '@angular/core/testing';

import { EducationexperienceService } from './educationexperience.service';

describe('EducationexperienceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: EducationexperienceService = TestBed.get(EducationexperienceService);
    expect(service).toBeTruthy();
  });
});
