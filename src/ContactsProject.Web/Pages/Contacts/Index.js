$(function () {
    var l = abp.localization.getResource('ContactsProject');
    var createModal = new abp.ModalManager(abp.appPath + 'Contacts/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Contacts/EditModal');

    var dataTable = $('#ContactsTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(contactsProject.contacts.contact.getList),
            columnDefs: [
                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    visible: abp.auth.isGranted('ContactsProject.Contacts.Edit'), //CHECK for the PERMISSION
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    visible: abp.auth.isGranted('ContactsProject.Contacts.Delete'), //CHECK for the PERMISSION
                                    confirmMessage: function (data) {
                                        return l('ContactDeletionConfirmationMessage');
                                    },
                                    action: function (data) {
                                        contactsProject.contacts.contact
                                            .delete(data.record.id)
                                            .then(function() {
                                                abp.notify.info(
                                                    l('SuccessfullyDeleted')
                                                );
                                                dataTable.ajax.reload();
                                            });
                                    }
                                }
                            ]
                    }
                },
                {
                    title: l('FirstName'),
                    data: "firstName",
                },
                {
                    title: l('LastName'),
                    data: "lastName",
                },
                {
                    title: l('Birthday'),
                    data: "birthday",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString();
                    },
                },
                {
                    title: l('PhoneNumber'),
                    data: "phoneNumber",
                },
                {
                    title: l('Email'),
                    data: "email",
                },
                {
                    title: l('StreetAddress'),
                    data: "streetAddress",
                },
                {
                    title: l('City'),
                    data: "city",
                },
                {
                    title: l('State'),
                    data: "state",
                },
                {
                    title: l('Zip'),
                    data: "zip",
                },
            ]
        })
    );

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewContactButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
