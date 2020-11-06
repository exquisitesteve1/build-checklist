import { Component, OnInit } from '@angular/core';
import {checklist} from '../..//ViewModels/checklist-view-model'

@Component({
  selector: 'app-build-checklist-management',
  templateUrl: './build-checklist-management.component.html',
  styleUrls: ['./build-checklist-management.component.css']
})
export class BuildChecklistManagementComponent implements OnInit {

  checklist:checklist[]
  constructor() { }

  ngOnInit(): void {
    this.checklist =[
      {
        id:1,
        title: 'task 1',
        completed: false
      },
      {
        id:2,
        title: 'task 2',
        completed: true
      },
      {
        id:3,
        title: 'task 3',
        completed: false
      }
    ]
  }

}
