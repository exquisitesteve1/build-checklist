import { Component, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

import { ConversionsView } from '../../ViewModels/conversions-view-model';
import { Observable } from 'rxjs';
import { ConversionsService } from '../../services/conversions.service';
// import { UserEditorComponent } from './user-editor/user-editor.component';
// import { UserAddComponent } from './user-add/user-add.component';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  Conversion: ConversionsView[];
  tempConversion: ConversionsView[];
  editedConversion: ConversionsView[];
  tempStorage: ConversionsView[];
  newId: number;

  constructor(private conversionsService: ConversionsService, private modalService: NgbModal) { }

  ngOnInit(): void {
    this.refreshList();
  }

  refreshList(): void{
    this.conversionsService.getConversionsList().subscribe((items) => {
      this.Conversion = items;
      this.tempConversion = this.Conversion;
    });
  }

  
  // onEditClick(user:UserView): void{
  //   var ref = this.modalService.open(UserEditorComponent);
  //   ref.componentInstance.user = user;

  //   ref.result.then((result) => this.onUserEdited(result)).catch(error => alert('Edit operation cancelled by user. No changes were made.'));
  // }

  // onUserEdited(editedUser: UserView): void{
  //   this.userService.updateUserInDB(editedUser).subscribe((editedItem)=>{
  //     alert("User edited successfully");
  //     this.refreshList();
  //   });
  // }

  
  // onAddClick(){
  //   var ref = this.modalService.open(UserAddComponent);
  //   ref.result.then((result) => this.onUserAdded(result)).catch(error => alert('Add operation cancelled by user. No new users were added.'));
  // }

  // onUserAdded(addedUser: UserView): void{
  //   this.userService.addNewUserToDB(addedUser).subscribe((addedItem) => {
  //     alert("New User Saved");
  //     this.refreshList();
  //   });
  // }

  // //add delete part

}
