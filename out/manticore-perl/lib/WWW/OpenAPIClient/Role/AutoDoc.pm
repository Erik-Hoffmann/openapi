=begin comment

Manticore Search API

This is the API for Manticore Search HTTP protocol 

The version of the OpenAPI document: 1.0.0
Contact: adrian.nuta@manticoresearch.com
Generated by: https://openapi-generator.tech

=end comment

=cut

#
# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# Do not edit the class manually.
# Ref: https://openapi-generator.tech
#
package WWW::OpenAPIClient::Role::AutoDoc;
use List::MoreUtils qw(uniq);

use Moose::Role;

sub autodoc {
    my ($self, $how) = @_;

    die "Unknown format '$how'" unless $how =~ /^(pod|wide|narrow)$/;

    $self->_printisa($how);
    $self->_printmethods($how);
    $self->_printattrs($how);
    print "\n";
}

sub _printisa {
    my ($self, $how) = @_;
    my $meta = $self->meta;

    my $myclass = ref $self;

    my $super = join ', ', $meta->superclasses;
    my @roles = $meta->calculate_all_roles;
    #shift(@roles) if @roles > 1; # if > 1, the first is a composite, the rest are the roles

    my $isa =   join ', ', grep {$_ ne $myclass} $meta->linearized_isa;
    my $sub =   join ', ', $meta->subclasses;
    my $dsub =  join ', ', $meta->direct_subclasses;

    my $app_name = $self->version_info->{app_name};
    my $app_version = $self->version_info->{app_version};
    my $generated_date = $self->version_info->{generated_date};
    my $generator_class = $self->version_info->{generator_class};

    $~ = $how eq 'pod' ? 'INHERIT_POD' : 'INHERIT';
    write;

    my ($rolepkg, $role_reqs);

    foreach my $role (@roles) {
        $rolepkg = $role->{package} || next; # some are anonymous, or something
        next if $rolepkg eq 'WWW::OpenAPIClient::Role::AutoDoc';
        $role_reqs = join ', ', keys %{$role->{required_methods}};
        $role_reqs ||= '';
        $~ = $how eq 'pod' ? 'ROLES_POD' : 'ROLES';
        write;
    }

    if ($how eq 'pod') {
        $~ = 'ROLES_POD_CLOSE';
        write;
    }

# ----- format specs -----
    format INHERIT = 

@* -
$myclass
                  ISA: @*
                       $isa
    Direct subclasses: @*
                       $dsub
       All subclasses: @*
                       $sub
                       
           Target API: @* @*
                       $app_name, $app_version
         Generated on: @*
                       $generated_date
      Generator class: @* 
                       $generator_class
                       
.
    format ROLES =   
             Composes: ^<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< ~
                       $rolepkg
                       requires: ^<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< ~
                                 $role_reqs
                                 ^<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< ~~
                                 $role_reqs
.

    format INHERIT_POD =
=head1 NAME

@*
$myclass

=head1 VERSION

=head2 @* version: @*
       $app_name,  $app_version
       
Automatically generated by the Perl Generator in the OpenAPI Generator project:

=over 4 

=item Build date: @*
                  $generated_date

=item Build package: @*
                     $generator_class

=item Codegen version: 


=back

=head1 INHERITANCE

=head2 Base class(es) 

@*
$isa

=head2 Direct subclasses

@*
$dsub
                   
=head2 All subclasses

@*
$sub

                
=head1 COMPOSITION

@* composes the following roles: 
$myclass 


.
    format ROLES_POD =
=head2 C<@*>
       $rolepkg
       
Requires:

@*
$role_reqs

.
    format ROLES_POD_CLOSE =


.
# ----- / format specs -----
}

sub _printmethods {
    my ($self, $how) = @_;

    if ($how eq 'narrow') {
        print <<HEAD;
METHODS
-------
HEAD
    }
    elsif ($how eq 'wide') {
        $~ = 'METHODHEAD';
        write;
    }
    elsif ($how eq 'pod') {
        $~ = 'METHODHEAD_POD';
        write;
    }
    else {
        die "Don't know how to print '$how'";
    }

    $self->_printmethod($_, $how) for uniq sort $self->meta->get_all_method_names; #$self->meta->get_method_list, 

    if ($how eq 'pod') {
        $~ = 'METHOD_POD_CLOSE';
        write;
    }


}

sub _printmethod {
    my ($self, $methodname, $how) = @_;
    return if $methodname =~ /^_/;
    return if $self->meta->has_attribute($methodname);
    my %internal = map {$_ => 1} qw(BUILD BUILDARGS meta can new DEMOLISHALL DESTROY 
        DOES isa BUILDALL does VERSION dump
        );
    return if $internal{$methodname};
    my $method = $self->meta->get_method($methodname) or return; # symbols imported into namespaces i.e. not known by Moose

    return if $method->original_package_name eq __PACKAGE__;

    my $delegate_to = '';
    my $via = '';
    my $on = '';
    my $doc = '';
    my $original_pkg = $method->original_package_name;
    if ($method->can('associated_attribute')) {
        $delegate_to = $method->delegate_to_method;
        my $aa = $method->associated_attribute;
        $on = $aa->{isa};
        $via = $aa->{name};
        $original_pkg = $on; 
        $doc = $original_pkg->method_documentation->{$delegate_to}->{summary};
    }
    else {
        $doc = $method->documentation;
    }

    if ($how eq 'narrow') {
        $~ = 'METHOD_NARROW';
        write;
    }
    elsif ($how eq 'pod' and $delegate_to) {
        $~ = 'METHOD_POD_DELEGATED';
        write;
    }
    elsif ($how eq 'pod') {
        $~ = 'METHOD_POD';
        write;
    }
    else {
        $~ = 'METHOD';
        write;
    }

# ----- format specs -----
    format METHODHEAD =

METHODS
-------
Name                                                  delegates to                                             on                                      via
===========================================================================================================================================================================
.
    format METHOD = 
@<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< @<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<... @<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<... @<<<<<<<<<<<<<<<<...
$methodname,                                          $delegate_to,                                            $on,                                    $via
.

    format METHOD_NARROW =
@*
$methodname
    original pkg: @*
                  $original_pkg
    delegates to: @*
                  $delegate_to
              on: @*
                  $on
             via: @*
                  $via

.

    format METHODHEAD_POD = 

=head1 METHODS

.
    
    format METHOD_POD = 
    
=head2 C<@*()>
       $methodname

       Defined in: @*
            $original_pkg


.
    format METHOD_POD_DELEGATED = 

=head2 C<@*()>
       $methodname

       Defined in: @*
                      $original_pkg
     Delegates to: @*()
                   $delegate_to
               On: @* 
                   $on
              Via: @*()
                   $via
              Doc: @*
                   $doc
          Same as: $self->@*->@*()
                     $via, $delegate_to

.
    format METHOD_POD_CLOSE =
    
.
# ----- / format specs -----
}

sub _printattrs {
    my ($self, $how) = @_;

    if ($how eq 'narrow') {
        print <<HEAD;
ATTRIBUTES
----------
HEAD
    }
    elsif ($how eq 'wide') {
        $~ = 'ATTRHEAD';
        write;
    }
    elsif ($how eq 'pod') {
        $~ = 'ATTRHEAD_POD';
        write;
    }
    else {
        die "Don't know how to print attributes '$how'";
    }

    $self->_printattr($_, $how) for sort $self->meta->get_attribute_list;

    if ($how eq 'pod') {
        $~ = 'ATTR_POD_CLOSE';
        write;
    }
}

sub _printattr {
    my ($self, $attrname, $how) = @_;
    return if $attrname =~ /^_/;
    my $attr = $self->meta->get_attribute($attrname) or die "No attr for $attrname";

    my $is;
    $is = 'rw' if $attr->get_read_method && $attr->get_write_method;
    $is = 'ro' if $attr->get_read_method && ! $attr->get_write_method;
    $is = 'wo' if $attr->get_write_method && ! $attr->get_read_method;
    $is = '--' if ! $attr->get_write_method && ! $attr->get_read_method;
    $is or die "No \$is for $attrname";

    my $tc = $attr->type_constraint || '';
    my $from = $attr->associated_class->name || '';
    my $reqd = $attr->is_required ? 'yes' : 'no';
    my $lazy = $attr->is_lazy ? 'yes' : 'no';
    my $has_doc = $attr->has_documentation ? 'yes' : 'no'; # *_api attributes will never have doc, but other attributes might have
    my $doc = $attr->documentation || '';
    my $handles = join ', ', sort @{$attr->handles || []};
    $handles ||= '';

    if ($how eq 'narrow') {
        $~ = 'ATTR_NARROW';
    }
    elsif ($how eq 'pod') {
        $~ = 'ATTR_POD';
    }
    else {
        $~ = 'ATTR';
    }

    write;

# ----- format specs -----
    format ATTRHEAD =

ATTRIBUTES
----------
Name                is isa                       reqd lazy doc handles
==============================================================================================================
.    
    format ATTR = 
@<<<<<<<<<<<<<<<<<  @< @<<<<<<<<<<<<<<<<<<<<<<<< @<<< @<<< @<< ^<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
$attrname,          $is, $tc,                    $reqd, $lazy, $has_doc, $handles
                                                               ^<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< ~~
                                                               $handles
.

    format ATTR_NARROW = 
@*
$attrname
         is: @*
             $is
        isa: @*
             $tc
       reqd: @*
             $reqd
       lazy: @*
             $lazy
        doc: @*
             $doc
    handles: ^<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
             $handles
             ^<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< ~~
             $handles

.
    format ATTRHEAD_POD =
=head1 ATTRIBUTES

.
    format ATTR_POD =

=head2 C<@*>
         $attrname

         is: @*
             $is
        isa: @*
             $tc
       reqd: @*
             $reqd
       lazy: @*
             $lazy
        doc: @*
             $doc
    handles: ^<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
             $handles
             ^<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< ~~
             $handles

.
    format ATTR_POD_CLOSE = 


.
# ----- / format specs -----
}



1;
