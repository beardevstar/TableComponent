/*
*	This project is built on .Net 5.0 but you can test it on older framework.
*	Copy 2 files - to your project's Client.Shared Folder - Colums.cs file and FilterTable.razor file to your project's Client.Shared Folder
	

	Components Attributes

	<FilterTable param="data" columns="cols" OnOkCallback="@OnCallBack" isoption=@option_flag>
        <TableTitle>Please select admins...</TableTitle>
        <Description>This is Modal Filter Table Sample for selecting Objects.</Description>
        <ItemIcon>
            <svg style="color: mediumpurple; display: inline; width: 2rem;" xmlns="http://www.w3.org/2000/svg" class="h-6 w-6" fill="none" viewBox="0 0 24 24" stroke="currentColor">
                <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M5.121 17.804A13.937 13.937 0 0112 16c2.5 0 4.847.655 6.879 1.804M15 10a3 3 0 11-6 0 3 3 0 016 0zm6 2a9 9 0 11-18 0 9 9 0 0118 0z" />
            </svg>  
        </ItemIcon>

        <ModalButton>
            <button>Click Here to See Modal Table with Selection</button>
        </ModalButton>
    </FilterTable>

    ......

    TableTitle - Title Of Modal Table - it appears at the top of Modal Table Widget
    Description - Description of this Widget - it appears under Table Title
    ItemIcon - Showing on row to identify items
    ModalButton - If user click this button, modal table showing

    ........
    [Parameter]
    public List<object> param { get; set; }
    You can display any object having unlimited attributes.

    [Parameter]
    public List<Column> columns { get; set; }
    //define your objects display attributes and it's title

    [Parameter]
    public Action<List<Object>> OnOkCallback { get; set; }
    //when user click OK button on table Modal Widget, this function is invoked.
    //argument is a list of objects(passed before) - you should convert this object to appropriate type.

    [Parameter]
    public bool isoption { get; set; } = false;
    //if this is set to true, user can select items with option.
*/