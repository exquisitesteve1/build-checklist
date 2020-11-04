import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BuildChecklistManagementComponent } from './build-checklist-management.component';

describe('BuildChecklistManagementComponent', () => {
  let component: BuildChecklistManagementComponent;
  let fixture: ComponentFixture<BuildChecklistManagementComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BuildChecklistManagementComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BuildChecklistManagementComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
