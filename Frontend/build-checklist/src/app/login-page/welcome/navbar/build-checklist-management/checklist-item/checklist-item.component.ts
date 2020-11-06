import { Component, OnInit, Input } from '@angular/core';
import { checklist } from '../../../ViewModels/checklist-view-model';

@Component({
  selector: 'app-checklist-item',
  templateUrl: './checklist-item.component.html',
  styleUrls: ['./checklist-item.component.css']
})
export class ChecklistItemComponent implements OnInit {
  @Input() checklist:checklist;

  constructor() { }

  ngOnInit(): void {
  }


  // Set Dynamic Classes
  setClasses() {
    let classes = {
      todo: true,
      'is-complete': this.checklist.completed
    }

    return classes
  }

  onToggle(todo) {
    // Toggle in UI
    todo.completed = !todo.completed;
    // Toggle on server
    // this.todoService.toggleCompleted(todo).subscribe(todo => console.log(todo));
  }

  onDelete(todo) {
    // this.deleteTodo.emit(todo);
    console.log('delete');
  }


}
