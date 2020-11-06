import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class ChecklistService {

  constructor() { }

  getchecklist(){
    return [
      {
        id:1,
        title: 'task before starting conversion',
        completed: false
      },
      {
        id:2,
        title: 'task during conversion',
        completed: true
      },
      {
        id:3,
        title: 'task at the end of migration',
        completed: false
      }
    ]
  }
}
